SELECT w.id
FROM Weather w
JOIN Weather yesterday
ON DATEDIFF(DAY, yesterday.recordDate, w.recordDate) = 1
WHERE w.temperature > yesterday.temperature
