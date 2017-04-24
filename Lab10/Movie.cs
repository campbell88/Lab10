using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Movie
    {
        private string Category;
        private string Title;
     
        
        public string MovieCategory
        {
            set
            {
                Category = value;
            }
            get
            {
                return Title;

            }


        }
        public string MovieTitle
        {
            set
            {
                Title = value;
            }
            get
            {
                return Title;
            }


        }
        public void SetMovieCategory (string Categoryinput)
        {
            Category = Categoryinput;
        }
        public void SetTitle (string Titleinput)
        {
            Title = Titleinput;
        }

    }
}
