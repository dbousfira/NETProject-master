using ClassLibrary1.Model.Entities;
using displayProduit.ViewModels.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ClassLibrary1.BusinessLayer;

namespace displayProduit.ViewModels
{
    /// <summary>
    /// ViewModel représentant un Produit (avec son détail)
    /// Hérite de BaseViewModel
    /// </summary>
    public class DetailProduitViewModel : BaseViewModel
    {
        #region Variables

        private int _id;
        private int _code;
        private string _libele;
        private RelayCommand _updateOperation;
        

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// <param name="p">Produit à transformer en DetailProduitViewModel</param>
        /// </summary>
        public DetailProduitViewModel(Produit p)
        {
            _code = p.ProduitCode;
            _libele = p.ProduitLibele;
        }

        #endregion

        #region Data Bindings

        /// <summary>
        /// ID du produit
        /// </summary>
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }


        /// <summary>
        /// Code du produit
        /// </summary>
        public int Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>
        /// Nom du produit
        /// </summary>
        public string Nom
        {
            get { return _libele; }
            set { _libele = value; }
        }

        #endregion

        #region Commandes

        /// <summary>
        /// Commande pour ouvrir la fenêtre pour ajouter une opération
        /// </summary>
        public ICommand UpdateOperation
        {
            get
            {
                if (_updateOperation == null)
                    _updateOperation = new RelayCommand(() => this.Update());
                return _updateOperation;
            }
        }

        /// <summary>
        /// Permet l'ouverture de la fenêtre
        /// </summary>
        private void Update()
        {
            Manager.Instance().UpdateProduit(new Produit(_id, _code, _libele));
        }

        #endregion
    }


}