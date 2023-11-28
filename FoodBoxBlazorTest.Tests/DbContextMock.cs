using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FoodBoxBlazorTest.Tests
{
    public class DbContextMock
    {

        /// <summary>
        /// GetMock is going to return a DbContext with given data and DbContext
        /// </summary>
        /// <typeparam name="TData"></typeparam>
        /// <typeparam name="TContext"></typeparam>
        /// <param name="listData"></param>
        /// <param name="dbSetSelectionExpression"></param>
        /// <returns></returns>
        public static TContext GetMock<TData, TContext>(List<TData> listData, Expression<Func<TContext, DbSet<TData>>> dbSetSelectionExpression) where TData : class where TContext : DbContext 
        { 
            IQueryable<TData> listDataQueryable = listData.AsQueryable(); // this is giong to add queries to the data that you have given us.
            Mock<DbSet<TData>> dbSetMock = new Mock<DbSet<TData>>(); // Creates a Mock of Classes in the DbContext.
            Mock<TContext> dbContext = new Mock<TContext>(); // Creates a Mock of DbContext, this is a physical DbContext.

            // We are creating and using LINQ
            dbSetMock.As<IQueryable<TData>>().Setup(s => s.Provider).Returns(listDataQueryable.Provider);
            // This is saying: here is like a helper that takes your question, understands it, and goes through the list to give you the answer.
            // It is like a smart assistant the makes sure that your questions work with the questions you have
            dbSetMock.As<IQueryable<TData>>().Setup(s => s.Expression).Returns(listDataQueryable.Expression);
            // The 'expression' this is returning is an expression tree
            dbSetMock.As<IQueryable<TData>>().Setup(s => s.ElementType).Returns(listDataQueryable.ElementType);
            // Just returning the type
            dbSetMock.As<IQueryable<TData>>().Setup(s => s.GetEnumerator()).Returns(() => listDataQueryable.GetEnumerator());
            // Returns an enumerator that iterates through the collection
            dbSetMock.Setup(x => x.Add(It.IsAny<TData>())).Callback<TData>(listData.Add);
            // Now this TContest persists data
            dbSetMock.Setup(x => x.AddRange(It.IsAny<IEnumerable<TData>>())).Callback<IEnumerable<TData>>(listData.AddRange);
            dbSetMock.Setup(x => x.Remove(It.IsAny<TData>())).Callback<TData>(t => listData.Remove(t));
            dbSetMock.Setup(x => x.RemoveRange(It.IsAny<IEnumerable<TData>>())).Callback<IEnumerable<TData>>(ts =>
            {
                foreach (var t in ts) { listData.Remove(t); }
            });


            dbContext.Setup(dbSetSelectionExpression).Returns(dbSetMock.Object);

            return dbContext.Object;
        }
    }
}
