using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Owo.Snake;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Owo
{
    public class Score
    {
        public string name { get; set; }
        public int score { get; set; }
        public Score(int pScore, string pName)
        {
            name = pName;
            score = pScore;
        }
    }
    public class Scores : List<Score>
    {
        public void Show(System.Windows.Forms.ListView owo)
        {
            owo.BeginUpdate();
            owo.Items.Clear();
            List<Score> meow = this.OrderByDescending(x => x.score).ToList();
            meow.ForEach((Score uwu) =>
            {
                ListViewItem owu = new ListViewItem((meow.IndexOf(uwu) + 1).ToString());
                owu.SubItems.Add(uwu.name);
                owu.SubItems.Add(uwu.score.ToString());
                owo.Items.Add(owu);
            });
            owo.EndUpdate();
        }
    }
}
