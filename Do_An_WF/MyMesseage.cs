using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_WF
{
    class MyMesseage
    {
        public static System.Windows.Forms.DialogResult ShowMessage(string caption, System.Windows.Forms.MessageBoxButtons button, System.Windows.Forms.MessageBoxIcon icon)
        {
            System.Windows.Forms.DialogResult dlgResult = System.Windows.Forms.DialogResult.None;
            switch (button)
            {
                case System.Windows.Forms.MessageBoxButtons.OK:
                    using (FormMesseageBoxOK msgOK = new FormMesseageBoxOK())
                    {
                        
                        msgOK.Message = caption;
                        switch (icon)
                        {
                            case System.Windows.Forms.MessageBoxIcon.Information:
                               msgOK.GetAnh = Properties.Resources.Tick_Mark_Dark_512;
                                break;
                          
                            case System.Windows.Forms.MessageBoxIcon.Error:
                                msgOK.GetAnh = Properties.Resources.cancel__3_;
                                break;
                            case System.Windows.Forms.MessageBoxIcon.Warning:
                                msgOK.GetAnh = Properties.Resources.icons8_more_info_96;
                                break;
                        }

                        dlgResult = msgOK.ShowDialog();
                    }
                    break;
                case System.Windows.Forms.MessageBoxButtons.YesNo:
                    using (FormMesseageBoxYesNo msgYesNo = new FormMesseageBoxYesNo())
                    {
                       // msgYesNo.Text = caption;
                        msgYesNo.Message = caption;
                        switch (icon)
                        {
                            case System.Windows.Forms.MessageBoxIcon.Question:
                                
                                break;
                        }
                        dlgResult = msgYesNo.ShowDialog();
                    }
                    break;
            }
            return dlgResult;
        }
    }
}
