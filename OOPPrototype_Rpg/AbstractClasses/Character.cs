using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPPrototype_Rpg
{
    public abstract class Character
    {
        public int Health { get; set; }
        public int Damage { get; set; }
        public virtual void Attack()
        {
            MessageBox.Show($"Attacked by {this.GetType().Name}");
        }
    }
}
