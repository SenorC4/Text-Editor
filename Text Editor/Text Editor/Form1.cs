using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Editor
{
    public partial class TextEditor : Form
    {
        public TextEditor()
        {
            InitializeComponent();
        }

        #region "Main"
        private void MenuFormat_Click(object sender, EventArgs e)
        {
     
        }

        private void MenuFile_Click(object sender, EventArgs e)
        {

        }

        private void MenuEdit_Click(object sender, EventArgs e)
        {

        }
        private void TxtDocument_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region "File Menu"
        //File Menu: Exit
        private void MenuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("save");
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("save as");
        }

        private void MenuNew_Click(object sender, EventArgs e)
        {
            MessageBox.Show("new");
        }

        private void MenuOpen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("open");
        }

        private void MenuPrintPreview_Click(object sender, EventArgs e)
        {
            MessageBox.Show("print preview");
        }

        private void MenuPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("print");
        }

        #endregion

        #region "Edit Menu"
        //----------------------EDIT-----------------------------
        private void MenuUndo_Click(object sender, EventArgs e)
        {

        }

        private void MenuRedo_Click(object sender, EventArgs e)
        {

        }

        private void MenuCopy_Click(object sender, EventArgs e)
        {

        }

        private void MenuPaste_Click(object sender, EventArgs e)
        {

        }

        private void MenuDelete_Click(object sender, EventArgs e)
        {

        }

        private void MenuSelectAll_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region "Format Menu"
        //------------------------FORMAT---------------------------------

        //Format Menu: Fore Color
        private void MenuColorRed_Click(object sender, EventArgs e)
        {
            if (MenuColorRed.Checked)
            {
                MenuColorRed.Checked = false;
                txtDocument.ForeColor = MenuSave.ForeColor;
            }
            else
            {
                MenuColorRed.Checked = true;
                txtDocument.ForeColor = MenuColorRed.ForeColor;

            }

        }

        //Format Menu: Fore Color
        private void MenuColorGreen_Click(object sender, EventArgs e)
        {
            if (MenuColorGreen.Checked)
            {
                MenuColorGreen.Checked = false;
                txtDocument.ForeColor = MenuSave.ForeColor;
            }
            else
            {
                MenuColorRed.Checked = true;
                txtDocument.ForeColor = MenuColorGreen.ForeColor;
            }
        }

        //Format Menu: Fore Color
        private void MenuColorBlue_Click(object sender, EventArgs e)
        {
            if (MenuColorBlue.Checked)
            {
                MenuColorBlue.Checked = false;
                txtDocument.ForeColor = MenuSave.ForeColor;
            }
            else
            {

                MenuColorBlue.Checked = true;
                txtDocument.ForeColor = MenuColorBlue.ForeColor;
            }
        }

        //Format Menu: Back Color
        private void MenuPink_Click(object sender, EventArgs e)
        {
            if (MenuPink.Checked)
            {
                MenuPink.Checked = false;
                txtDocument.BackColor = MenuSave.BackColor;
            }
            else
            {
                MenuPink.Checked = true;
                txtDocument.BackColor = MenuPink.BackColor;
            }

            MenuLightGreen.Checked = false;
            MenuLightBlue.Checked = false;
            MenuWhite.Checked = false;
        }

        //Format Menu: Back Color
        private void MenuLightGreen_Click(object sender, EventArgs e)
        {
            if (MenuLightGreen.Checked)
            {
                MenuLightGreen.Checked = false;
                txtDocument.BackColor = MenuSave.BackColor;
            }
            else
            {
                MenuLightGreen.Checked = true;
                txtDocument.BackColor = MenuLightGreen.BackColor;
            }
            MenuPink.Checked = false;
            MenuLightBlue.Checked = false;
            MenuWhite.Checked = false;

        }

        //Format Menu: Back Color
        private void MenuLightBlue_Click(object sender, EventArgs e)
        {
            if (MenuLightBlue.Checked)
            {
                MenuLightBlue.Checked = false;
                txtDocument.BackColor = MenuSave.BackColor;
            }
            else
            {
                MenuLightBlue.Checked = true;
                txtDocument.BackColor = MenuLightBlue.BackColor;
            }

            MenuPink.Checked = false;
            MenuWhite.Checked = false;
            MenuLightGreen.Checked = false;
        }
        private void MenuWhite_Click(object sender, EventArgs e)
        {
            if (MenuWhite.Checked)
            {
                MenuWhite.Checked = false;
                txtDocument.BackColor = MenuSave.BackColor;
            }
            else
            {
                MenuWhite.Checked = true;
                txtDocument.BackColor = MenuWhite.BackColor;
            }
            MenuLightBlue.Checked = false;
            MenuPink.Checked = false;
            MenuLightGreen.Checked = false;
        }

        //Format Menu: Text Size
        private void MenuTextSmall_Click(object sender, EventArgs e)
        {
            if (MenuTextSmall.Checked)
            {
                MenuTextSmall.Checked = false;
                txtDocument.Font = MenuSave.Font;
            }
            else
            {
                MenuTextSmall.Checked = true;
                txtDocument.Font = MenuTextSmall.Font;
            }


        }

        //Format Menu: Text Size
        private void MenuTextNormal_Click(object sender, EventArgs e)
        {
            if (MenuTextNormal.Checked)
            {
                MenuTextNormal.Checked = false;
                txtDocument.Font = MenuSave.Font;
            }
            else
            {
                MenuTextNormal.Checked = true;
                txtDocument.Font = MenuTextNormal.Font;
            }

        }

        //Format Menu: Text Size
        private void MenuTextLarge_Click(object sender, EventArgs e)
        {
            if (MenuTextLarge.Checked)
            {
                MenuTextLarge.Checked = false;
                txtDocument.Font = MenuSave.Font;
            }
            else
            {
                MenuTextLarge.Checked = true;
                txtDocument.Font = MenuTextLarge.Font;
            }
        }

       

        //align
        private void FormatAlignLeft_Click(object sender, EventArgs e)
        {
            FormatAlignLeft.Checked = true;
            FormatAlignRight.Checked = false;
            FormatAlignCenter.Checked = false;
        }

        private void FormatAlignCenter_Click(object sender, EventArgs e)
        {
            FormatAlignLeft.Checked = false;
            FormatAlignRight.Checked = false;
            FormatAlignCenter.Checked = true;
        }

        private void FormatAlignRight_Click(object sender, EventArgs e)
        {
            FormatAlignLeft.Checked = false;
            FormatAlignRight.Checked = true;
            FormatAlignCenter.Checked = false;
        }

        //offset
        private void FormatOffsetNormal_Click(object sender, EventArgs e)
        {
            FormatOffsetNormal.Checked = true;
            FormatOffsetSuperscript.Checked = false;
            FormatOffsetSubscript.Checked = true;
        }

        private void FormatOffsetSubscript_Click(object sender, EventArgs e)
        {
            FormatOffsetNormal.Checked = false;
            FormatOffsetSubscript.Checked = true;
            FormatOffsetSuperscript.Checked = false;
        }

        private void FormatOffsetSuperscript_Click(object sender, EventArgs e)
        {
            FormatOffsetNormal.Checked = false;
            FormatOffsetSuperscript.Checked = true;
            FormatOffsetSubscript.Checked = false;
        }

        //indent
        private void FormatIndent_Click(object sender, EventArgs e)
        {

        }
        private void FormatIndentNone_Click(object sender, EventArgs e)
        {
            FormatIndentNone.Checked = true;
            FormatIndentHanging.Checked = false;
            FormatIndentLeft.Checked = false;
            FormatIndentRight.Checked = false;
            FormatIndentBoth.Checked = false;

        }

        private void FormatIndentHanging_Click(object sender, EventArgs e)
        {
            FormatIndentNone.Checked = false;
            FormatIndentHanging.Checked = true;
            FormatIndentLeft.Checked = false;
            FormatIndentRight.Checked = false;
            FormatIndentBoth.Checked = false;
        }

        private void FormatIndentLeft_Click(object sender, EventArgs e)
        {
            FormatIndentNone.Checked = false;
            FormatIndentHanging.Checked = false;
            FormatIndentLeft.Checked = true;
            FormatIndentRight.Checked = false;
            FormatIndentBoth.Checked = false;
        }

        private void FormatIndentRight_Click(object sender, EventArgs e)
        {
            FormatIndentNone.Checked = false;
            FormatIndentHanging.Checked = false;
            FormatIndentLeft.Checked = false;
            FormatIndentRight.Checked = true;
            FormatIndentBoth.Checked = false;
        }

        private void FormatIndentBoth_Click(object sender, EventArgs e)
        {
            FormatIndentNone.Checked = false;
            FormatIndentHanging.Checked = false;
            FormatIndentLeft.Checked = false;
            FormatIndentRight.Checked = false;
            FormatIndentBoth.Checked = true;

        }

        //bullet
        private void FormatBullet_Click(object sender, EventArgs e)
        {
            if (FormatBullet.Checked || ContextBullet.Checked)
            {
                ContextBullet.Checked = false;
                FormatBullet.Checked = false;
            }
            else
            {
                FormatBullet.Checked = true;
                txtDocument.SelectionBullet = true;
                FormatBullet.Checked = true;
            }
            
        }



        #endregion

        #region "Context"
        private void ContextBullet_Click(object sender, EventArgs e)
        {
            if (FormatBullet.Checked || ContextBullet.Checked)
            {
                ContextBullet.Checked = false;
                FormatBullet.Checked = false;
            }
            else
            {
                txtDocument.SelectionBullet = true;
                ContextBullet.Checked = true;
                FormatBullet.Checked = true;
            }
            
        }

        private void ContextPink_Click(object sender, EventArgs e)
        {
            if (ContextPink.Checked)
            {
                ContextPink.Checked = false;
                txtDocument.BackColor = MenuSave.BackColor;
            }
            else
            {
                ContextPink.Checked = true;
                ContextBlue.Checked = false;
                ContextGreen.Checked = false;
                txtDocument.BackColor = MenuPink.BackColor;
            }
        }

        private void ContextWhite_Click(object sender, EventArgs e)
        {
            if (MenuWhite.Checked)
            {
                MenuWhite.Checked = false;
                txtDocument.BackColor = MenuSave.BackColor;
            }
            else
            {
                MenuWhite.Checked = true;
                txtDocument.BackColor = MenuWhite.BackColor;
            }
            MenuLightBlue.Checked = false;
            MenuPink.Checked = false;
            MenuLightGreen.Checked = false;
        }

        private void ContextBlue_Click(object sender, EventArgs e)
        {
            if (ContextBlue.Checked)
            {
                ContextBlue.Checked = false;
                txtDocument.BackColor = MenuSave.BackColor;
            }
            else
            {
                ContextBlue.Checked = true;
                ContextPink.Checked = false;
                ContextGreen.Checked = false;
                txtDocument.BackColor = MenuLightBlue.BackColor;
            }
        }

        private void ContextGreen_Click(object sender, EventArgs e)
        {
            if (ContextGreen.Checked)
            {
                ContextGreen.Checked = false;
                txtDocument.BackColor = MenuSave.BackColor;
            }
            else
            {
                ContextGreen.Checked = true;
                ContextPink.Checked = false;
                ContextBlue.Checked = false;
                txtDocument.BackColor = MenuLightGreen.BackColor;
            }
        }


        #endregion

        
    }
}
