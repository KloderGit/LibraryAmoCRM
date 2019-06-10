using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRM.Interfaces.Entity
{
    public interface INote : IElement, IBelong
    {
        string Text { get; set; }

        bool IsEditable { get; set; }

        string Attachment { get; set; }

        int NoteType { get; set; }

        INoteParam Params { get; set; }
    }

    public interface INoteParam
    {
        string Text { get; set; }

        string Service { get; set; }
    }
}
