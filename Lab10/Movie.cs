using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Movie
    {

        #region Variables

        // Declare Variables
        private string Category;
        private string Title;

        #endregion


        #region Properties

        // Property - Category
        public string MovieCategory
        {
            set
            {
                Category = value;
            }

            get
            {
                return Category;
            }
        }


        // Property - Title
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

        #endregion



        #region Constructors

        // Input
        public Movie(string TitleInput,
            string CategoryInput)
        {

            Category = CategoryInput;
            Title = TitleInput;
        }


        ////Default Input
        //public Movie()
        //{

        //    Category = "Science Fiction";
        //    Title = "Dark Skies";
        //}
        #endregion
    }
}
