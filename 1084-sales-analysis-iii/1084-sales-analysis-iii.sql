 SELECT DISTINCT s.product_id, p.product_name
 FROM Sales AS s
 LEFT JOIN Product AS p
 ON p.product_id=s.product_id
 WHERE s.sale_date BETWEEN '2019-01-01' AND '2019-03-31' 
 
 EXCEPT 
 
 SELECT DISTINCT s.product_id, p.product_name
 FROM Sales AS s
 LEFT JOIN Product AS p
 ON p.product_id=s.product_id
 WHERE s.sale_date NOT BETWEEN '2019-01-01' AND '2019-03-31' 