using System;
using System.Collections.Generic;
using System.Text;

namespace MySimpleNotesApp.Models
{
    public class Note
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string NoteTitle {  get; set; }
        public string NoteContent { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
