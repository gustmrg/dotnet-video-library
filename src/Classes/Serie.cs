using System;

namespace VideoLibrary
{
    public class Serie : Entity
    {
        public Serie(int Id, Genre Genre, string Title, string Description, int Year)
        {
            this.Id = Id;
            this.Genre = Genre;
            this.Title = Title;
            this.Description = Description;
            this.Year = Year;
            this.Hidden = false;
        }

        public Serie()
        {
            
        }

        private string Title { get; set; }
        private string Description { get; set; }
        private Genre Genre { get; set; }
        private int Year { get; set; }
        private bool Hidden { get; set; }

        
        public override string ToString()
        {
            string value = "";
            value += "Titulo: " + this.Title + Environment.NewLine;
            value += "Genero: " + this.Genre + Environment.NewLine;
            value += "Descricao: " + this.Description + Environment.NewLine;
            value += "Ano de Inicio: " + this.Year;
            return value;
        }

        public string getTitle()
        {
            return this.Title;
        }

        public int getId()
        {
            return this.Id;
        }

        public void Hide()
        {
            this.Hidden = true;
        }

    }


}