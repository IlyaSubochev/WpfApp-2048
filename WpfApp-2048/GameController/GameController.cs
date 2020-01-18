using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game2048;

namespace WpfApp_2048.GameController
{
    class GameController
    {
        Model model = new Model(4);
        void Start()
        { }

        void Update()
        {
            Show();
        }

        void Show()
        {
            for (int x = 0; x < model.size; x++)
                for (int y = 0; y < model.size; y++)
                    ShowText("b" + x + y, model.GetMap(x, y));
        }

        private void ShowText(string name, int number)
        {
            throw new NotImplementedException();
        }

        public void ClickButtonStart()
        {
            model.Start();
            Show();
        }
    }
}
