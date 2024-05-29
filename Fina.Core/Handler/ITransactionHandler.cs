using Fina.Core.Models;
using Fina.Core.Requests.Transactions;
using Fina.Core.Responses;

namespace Fina.Core.Handler;

public interface ITransactionHandler
{
    Task<Response<Transaction?>> CreateAsync(CreateTransactionRequest request);

    Task<Response<Transaction?>> UpdateAsync(UpdateTransactionRequest request);

    Task<Response<Transaction?>> DeleteAsync(UpdateTransactionRequest request);

    Task<Response<Transaction?>> GetByIdAsync(GetTransactionByIdRequest request);

    Task<Response<List<Transaction>?>> GetByPeriodAsync(GetTransactionsByPeriodRequest request);

}