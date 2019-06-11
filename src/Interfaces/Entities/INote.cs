namespace LibraryAmoCRM.Interfaces
{
    public interface INote : IEntity, IToDoObject, IBelong
    {
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
