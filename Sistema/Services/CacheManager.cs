using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Controles.Logica;

namespace Sistema.Services
{
    public class CacheManagerList
    {
        // Esta clase se encargará de almacenar en caché las listas de estantes, categorías y lotes
        // para evitar que se hagan consultas a la base de datos cada vez que se necesite una lista.
        private readonly object _lock = new object();
        private List<EstantesModel> _shelvesListModel;
        private List<CategoriasModel> _categoryListModel;
        private List<LotesModel> _loteListModel;

        private readonly EstanteLogica shelfLogic = new EstanteLogica();
        private readonly CategoriaLogica categoryLogic = new CategoriaLogica();
        private readonly LoteLogica loteLogica = new LoteLogica();

        public List<EstantesModel> ShelvesListModel
        {
            get
            {
                // Esto permite que solo un hilo pueda acceder a la lista a la vez
                lock (_lock)
                {
                    if (_shelvesListModel == null)
                    {
                        _shelvesListModel = shelfLogic.GetShelves();
                    }
                    return _shelvesListModel;
                }
            }
            set
            {
                lock (_lock)
                {
                    _shelvesListModel = value;
                }
            }
        }

        public List<CategoriasModel> CategoryListModel
        {
            get
            {
                lock (_lock)
                {
                    if (_categoryListModel == null)
                    {
                        _categoryListModel = categoryLogic.GetCategories();
                    }
                    return _categoryListModel;
                }
            }
            set
            {
                lock (_lock)
                {
                    _categoryListModel = value;
                }
            }
        }

        public List<LotesModel> LoteListModel
        {
            get
            {
                lock (_lock)
                {
                    if (_loteListModel == null)
                    {
                        _loteListModel = loteLogica.GetLotesList();
                    }
                    return _loteListModel;
                }
            }
            set
            {
                lock (_lock)
                {
                    _loteListModel = value;
                }
            }
        }
    }

}
