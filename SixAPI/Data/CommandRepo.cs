using Microsoft.EntityFrameworkCore;
using SixAPI.Models;

namespace SixAPI.Data
{
    public class CommandRepo : ICommandRepo
    {
        private readonly AppDbContext _context;

        public CommandRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Command>> GetAllCommands()
        {
            return await _context.Commands!.ToListAsync();
        }

        public async Task CreateCommand(Command cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            await _context.Commands!.AddAsync(cmd);
        }

        public async Task<Command?> GetCommandById(int id)
        {
            return await _context.Commands!.FirstOrDefaultAsync(c => c.Id == id);
        }

      

        public void DeleteCommand(Command cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
            _context.Commands.Remove(cmd);
        }
    }
}