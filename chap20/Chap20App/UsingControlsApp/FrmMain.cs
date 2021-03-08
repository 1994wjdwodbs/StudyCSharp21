using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingControlsApp
{
    public partial class FrmMain : Form
    {
        FontStyle style = FontStyle.Regular;
        Random random = new Random(37);

        public FrmMain()
        {
            InitializeComponent();
        }

        #region 이벤트 핸들러 영역
        private void FrmMain_Load(object sender, EventArgs e)
        {
            LsvDummy.Columns.Add("Name");
            LsvDummy.Columns.Add("Depth");

            var FontsList = FontFamily.Families;
            foreach (var font in FontsList)
            {
                CboFont.Items.Add(font.Name);
            }
        }
        private void ChkBold_CheckedChanged(object sender, EventArgs e)
        {
            //     일반 텍스트입니다.
            // Regular = 0,
            //
            // 요약:
            //     굵게 표시 된 텍스트입니다.
            // Bold = 1,
            //
            // 요약:
            //     기울임꼴 텍스트입니다.
            // Italic = 2,
            //
            // 요약:
            //     밑줄이 그어진된 텍스트입니다.
            // Underline = 4,
            //
            // 요약:
            //     중간 취소선 텍스트입니다.
            // Strikeout = 8

            style ^= FontStyle.Bold;
            TxtResult.Font = new Font((string)CboFont.SelectedItem, 14, style);
        }

        private void ChkItalic_CheckedChanged(object sender, EventArgs e)
        {
            //     일반 텍스트입니다.
            // Regular = 0,
            //
            // 요약:
            //     굵게 표시 된 텍스트입니다.
            // Bold = 1,
            //
            // 요약:
            //     기울임꼴 텍스트입니다.
            // Italic = 2,
            //
            // 요약:
            //     밑줄이 그어진된 텍스트입니다.
            // Underline = 4,
            //
            // 요약:
            //     중간 취소선 텍스트입니다.
            // Strikeout = 8

            style ^= FontStyle.Italic;
            TxtResult.Font = new Font((string)CboFont.SelectedItem, 14, style);
        }

        private void CboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void TrbHandle_Scroll(object sender, EventArgs e)
        {
            PrbDisplay.Value = TrbHandle.Value;
        }

        /* * * * * * * * * * * * * *
         * 모달 윈도(Modal Window)는 사용자 인터페이스 디자인 개념에서 자식 윈도에서 부모 윈도로 돌아가기 전에 
         * 사용자의 상호동작을 요구하는 창을 말한다. 그래서 응용 프로그램의 주 창의 작업 흐름을 방해한다. 
         * 일반적으로 모달 대화상자로 불리는데, 그 이유는 대화상자를 부를 때 흔히 사용되기 때문이다. 
         * 우리가 자주 사용하는 파일 열기/저장 대화상자를 생각하면 이해하기 쉽다.
         * 
         * 모달 창들은 일반적으로 사용자의 명령을 인식하기 위해서나, 긴급 상황을 알리기 위해 많이 사용된다. 
         * 웹에서는 이미지 작업을 예로 든다면 이미지를 자세하게 볼 때 자주 사용된다.
         * * * * * * * * * * * * * */
        private void BtnModal_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modal Form";
            frm.Width = 300;
            frm.Height = 100;
            frm.BackColor = Color.Coral;
            frm.ShowDialog(); // 모달창 띄우기
            bool flag = false;
            flag ^= true;
        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            Form frm = new Form // Anonymous Class (무명 클래스)
            {
                Text = "Modaless Form",
                Width = 300,
                Height = 100,
                BackColor = Color.GreenYellow
            };
            frm.Show(); // 모달리스창 띄우기

        }

        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TxtResult.Text, "타이틀", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); // 모달창 메시지박스
        }

        private void BtnAddRoot_Click(object sender, EventArgs e)
        {
            TrvDummy.Nodes.Add(random.Next().ToString());

            DisplayTreeToList();
        }

        private void BtnAddChild_Click(object sender, EventArgs e)
        {
            if (TrvDummy.SelectedNode == null)
            {
                MessageBox.Show("선택된 노드가 없습니다", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TrvDummy.SelectedNode.Nodes.Add(random.Next().ToString());
            TrvDummy.SelectedNode.Expand();

            DisplayTreeToList();
        }
        #endregion

        #region 사용자 메서드 영역
        private void ChangeFont()
        {
            if (CboFont.SelectedIndex >= 0 && CboFont.SelectedIndex < FontFamily.Families.Length)
            {
                TxtResult.Font = new Font((string)CboFont.SelectedItem, 14, style);
                // TxtResult.Text = "Sample";
            }

            return;
        }

        public void DisplayTreeToList()
        {
            LsvDummy.Items.Clear();
            foreach (TreeNode node in TrvDummy.Nodes)
                DisplayTreeToList(node);
        }

        private void DisplayTreeToList(TreeNode node)
        {
            // throw new NotImplementedException();
            LsvDummy.Items.Add(new ListViewItem(new string[] {node.Text, node.FullPath}));

            foreach (TreeNode item in node.Nodes)
                DisplayTreeToList(item); // 재귀
        }
        #endregion

    }
}
