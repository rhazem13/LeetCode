SELECT name, balance
FROM (
  SELECT account, SUM(amount) as balance
  FROM Transactions
  GROUP BY account
) AS account_balances
JOIN Users ON account_balances.account = Users.account
WHERE balance > 10000;
