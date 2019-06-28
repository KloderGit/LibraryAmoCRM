﻿using System;

namespace LibraryAmoCRM.Interfaces
{
    public interface INote : IEntity, IToDoObject, IBelong
    {
        bool? IsEditable { get; set; }

        string Attachment { get; set; }

        int NoteType { get; set; }

        INoteParam Params { get; set; }
    }

    public interface INoteParam
    {
        string Text { get; set; }
        string Service { get; set; }

        string Sender { get; set; }
        string Html { get; set; }

        string Uniq { get; set; }
        string Link { get; set; }
        string Phone { get; set; }
        int Duration { get; set; }
        string From { get; set; }
        string Src { get; set; }
        string CallStatus { get; set; }
        string CallResult { get; set; }
    }
}
