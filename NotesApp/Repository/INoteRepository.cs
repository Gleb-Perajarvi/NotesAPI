using NotesApp.Model;

namespace NotesApp.Repository
{
    public interface INoteRepository
    {
        Task<IEnumerable<Note>> GetNotesAsync();
        Task<Note> GetNoteByIdAsync(int id);
        Task AddNoteAsync(Note note);
        Task UpdateNoteAsync(Note note);
        Task DeleteNoteAsync(int id);
    }
}
