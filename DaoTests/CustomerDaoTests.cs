using DataAccess.MemoryDaos;
using Model;

using DataAccess;

namespace DaoTests
{
    public class CustomerDaoTests
    {
        [Fact]
        public void TestGetOrderSuccess()
        {
            // Arrange
            IDao<Order> orderDao = DAOFactory.CreateOrderDao();

            // Act
            Order? test = orderDao.GetById(2);

            // Assert
            Assert.NotNull(test);
        }

        [Fact]
        public void TestDeleteOrderSuccess()
        {
            // Arrange
            IDao<Order> dao = DAOFactory.CreateOrderDao();
            Order? test = dao.GetById(1);

            // Act
            if (test != null)
            {
                dao.Delete(test);
            }

            // Assert
            Assert.Null(dao.GetById(1));
        }
    }
}