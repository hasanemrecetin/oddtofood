using OddToFood.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OddToFood.Data.Services
{
    public class ButtonService : IButtonService
    {

        List<Button> ButtonList = new List<Button>(){
            new Button{ Num = 1 , Name = "Cancel"},
            new Button{ Num = 2 , Name = "Sign"},
            new Button{ Num = 3 , Name = "Skip"}
            };

        public List<Button> getAll()
        {
            var result = ButtonList.OrderBy(x => x.Name).ToList();

            return result;
        }

        
    }
}
