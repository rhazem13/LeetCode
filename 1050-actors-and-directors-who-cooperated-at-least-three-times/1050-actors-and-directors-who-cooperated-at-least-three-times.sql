SELECT ad.actor_id, ad.director_id
FROM ActorDirector ad
JOIN (
  SELECT actor_id, director_id
  FROM ActorDirector
  GROUP BY actor_id, director_id
  HAVING COUNT(*) >= 3
) ad2 ON ad.actor_id = ad2.actor_id AND ad.director_id = ad2.director_id
GROUP BY ad.actor_id, ad.director_id
