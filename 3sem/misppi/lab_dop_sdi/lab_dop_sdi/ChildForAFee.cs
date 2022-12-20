using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_dop_sdi
{
    public class ChildForAFee
    {
        public int ID { get; private set; }
        private string _name;
        public string Name { get => _name; set { _name = value; Child.Text = value; } }
        public Детка Child { get; private set; }

        public ChildForAFee(int id)
        {
            ID = id;
            Child = new();
            Name = $"Детка {id}";
        }

        public void Show()
        {
            Child.Show();
        }

        public void Hide()
        {
            Child.Hide();
        }

        public void Close()
        {
            Child.Close();
        }

        public Point GetLocation()
        {
            return Child.Location;
        }

        public void ReSize(int width, int height) 
        { 
            Child.Size = new Size(width, height);
        }
    }
}
