using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2048
{
    public class Model
    {
        bool isGameOver;

        public int size { get; private set; }

        public Model(int size)
        {
            this.size = size;
        }

        public void Start()
        { 
        }

        public void Left()
        { 
        }

        public void Right()
        { 
        }

        public void Up()
        { 
        }

        public void Down()
        { 
        }

        public int GetMap (int x, int y)
        {
            return -1;
        }

        public bool isGameOver()
        {
            return isGameOver;
        }

    }   
}
