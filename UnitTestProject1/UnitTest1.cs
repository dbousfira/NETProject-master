using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1.BusinessLayer;
using ClassLibrary1.Model.Fluent;
using ClassLibrary1.Model.Entities;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        
        [TestMethod]
        public void Ajouter()
        {
            Produit p = new Produit(666);
            Manager.Instance().AddProduit(p);
            Assert.IsTrue(Manager.Instance().GetListeProduit().Contains(p));   
        }

   
    }
}
