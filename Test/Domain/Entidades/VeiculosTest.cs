using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public class VeiculoTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        // Arrange
        var adm = new Veiculo();

        // Act
        adm.Id = 1;
        adm.Nome = "Celta";
        adm.Marca = "Chevrolet";
        adm.Ano = 2015;

        // Assert
        Assert.AreEqual(1, adm.Id);
        Assert.AreEqual("Celta", adm.Nome);
        Assert.AreEqual("Chevrolet", adm.Marca);
        Assert.AreEqual(2015, adm.Ano);
    }
}