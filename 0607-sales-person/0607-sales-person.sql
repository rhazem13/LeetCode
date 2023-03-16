SELECT DISTINCT sp.name
FROM SalesPerson sp
LEFT JOIN Orders o ON sp.sales_id = o.sales_id
WHERE sp.sales_id NOT IN (
  SELECT DISTINCT o.sales_id
  FROM Orders o
  INNER JOIN Company c ON o.com_id = c.com_id
  WHERE c.name = 'RED'
);
