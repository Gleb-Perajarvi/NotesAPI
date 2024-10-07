using NotesApp.Model;
using NotesApp.Data;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace NotesApp.Repository
{
    public class NoteRepository : INoteRepository
    {
        private readonly AppDBContext _context;

        public NoteRepository(AppDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Note>> GetNotesAsync()
        {
            return await _context.Notes.ToListAsync();
        }

        public async Task<Note> GetNoteByIdAsync(int id)
        {
            var note = await _context.Notes.FindAsync(id);

            if (note == null)
            {
                Log.Warning($"Note with id = {id} not found");

                throw new KeyNotFoundException($"Note with id = {id} not found");
            }

            return note;
        }

        public async Task AddNoteAsync(Note note)
        {
            throw new NotImplementedException();
        }

        public Task DeleteNoteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateNoteAsync(Note note)
        {
            throw new NotImplementedException();
        }
    }
}
