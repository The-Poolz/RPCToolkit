﻿namespace RPC.Core.Transaction;

public interface ITransactionSender
{
    public string SendTransaction(string signedTransaction);
}
