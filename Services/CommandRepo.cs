using PizzaStore.Models;
using Microsoft.EntityFrameworkCore;

namespace PizzaStore.Service
{
    public class CommandRepo : ICommandRepo
    {
        private readonly WsApplicationDbContext _context;

        public CommandRepo(WsApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateCommand(Command cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException (nameof(cmd));
            }
            await _context.AddAsync(cmd);
        }

        public void DeleteCommand(Command cmd)
        {
            if(cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
            _context.commands?.Remove(cmd);
        }

        public async Task<IEnumerable<Command>> GetAllCommands()
        {
            return await _context.commands.ToListAsync();
        }

        public async Task<Command?> GetCommandById(int id)
        {
            return await _context.commands.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}