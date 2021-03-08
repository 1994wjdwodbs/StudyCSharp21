using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCopyApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                TxtSource.Text = dialog.FileName;
            }
        }

        private void BtnTarget_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                TxtTarget.Text = dialog.FileName;
            }
        }

        private async void BtnAsyncCopy_Click(object sender, EventArgs e)
        {
            long totalCopied = await CopyAsync(TxtSource.Text, TxtTarget.Text);
            MessageBox.Show($"{totalCopied}로 복사했습니다!", "비동기복사완료");
        }

        private void BtnSyncCopy_Click(object sender, EventArgs e)
        {
            long totalCopied = CopySync(TxtSource.Text, TxtTarget.Text);
            MessageBox.Show($"{totalCopied}로 복사했습니다!", "동기복사완료");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("취소");
        }
        // 비동기 복사
        private async Task<long> CopyAsync(string sourcePath, string targetPath)
        {
            // 비동기버튼 비활성화
            BtnSyncCopy.Enabled = false;
            // 전부 복사했는지 크기 확인
            long totalCopied = 0;

            using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open))
            {
                using (FileStream targetStream = new FileStream(targetPath, FileMode.Create))
                {
                    byte[] buffer = new byte[1024 * 1024]; //1024(1KB)
                    int nRead = 0;
                    while ((nRead = await sourceStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                    {
                        await targetStream.WriteAsync(buffer, 0, nRead); // 복사
                        totalCopied += nRead;

                        // 프로그래스바에 복사 상태 진행
                        PrbCopy.Value = (int)((totalCopied / sourceStream.Length) * 100);
                    }
                }
            }
            // copy 끝나면
            BtnSyncCopy.Enabled = true;
            return totalCopied;
        }

        // 동기 복사
        private long CopySync(string sourcePath, string targetPath)
        {
            // 비동기버튼 비활성화
            BtnAsyncCopy.Enabled = false;
            // 전부 복사했는지 크기 확인
            long totalCopied = 0;

            using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open))
            {
                using (FileStream targetStream = new FileStream(targetPath, FileMode.Create))
                {
                    byte[] buffer = new byte[1024]; //1024(1KB)
                    int nRead = 0;
                    while ((nRead = sourceStream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        targetStream.Write(buffer, 0, nRead); // 복사
                        totalCopied += nRead;

                        // 프로그래스바에 복사 상태 진행
                        PrbCopy.Value = (int) ((totalCopied / sourceStream.Length) * 100);
                    }
                }
            }
            // copy 끝나면
            BtnAsyncCopy.Enabled = true;
            return totalCopied;
        }
    }
}
