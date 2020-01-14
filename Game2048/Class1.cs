using System;

namespace Game2048
{
    public class Model
    {
        Map map;
        bool isGameOver;

        public int size 
        { 
            get 
                { 
                    return map.size; 
                }
        }

        public Model(int size)
        {
            map = new Map(size);
        }

        public void Start()
        {
            for (int x = 0; x < size; x++)
                for (int y = 0; y < size; y++)
                    map.Set(x, y, 0);
        }

        public void Left()
        { }

        public void Right()
        { }

        public void Up()
        { }

        public void Down()
        { }

        public int GetMap(int x, int y)
        {
            return map.Get(x, y);
        }

        public bool IsGameOver()
        {
            return isGameOver;
        }
    }
}
