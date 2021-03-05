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

        public FrmMain()
        {
            InitializeComponent();
        }

        private void ChangeFont()
        {
            if(CboFont.SelectedIndex >= 0 && CboFont.SelectedIndex < FontFamily.Families.Length)
            {
                TxtResult.Font = new Font((string)CboFont.SelectedItem, 14, style);
                // TxtResult.Text = "Sample";
            }

            return;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            var FontsList = FontFamily.Families;
            foreach(var font in FontsList)
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
    }
}
