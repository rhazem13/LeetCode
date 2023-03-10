WITH CTE AS (
  SELECT DISTINCT * FROM Activities
)

SELECT 
sell_date,
COUNT(product) AS num_sold,
STRING_AGG(product, ',') WITHIN GROUP (ORDER BY product ASC) AS products
FROM CTE
GROUP BY sell_date
ORDER BY 1 ASC