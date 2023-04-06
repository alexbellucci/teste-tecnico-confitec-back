using confitec_back.DL.DB;
using confitec_back.DL.Services.DAL;

namespace confitec_back.DAL.EF
{
    public class UsuarioRepository : GenericRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ConfitecBackContext confitecBackContext)
        : base(confitecBackContext)
        {
        }
    }
}
