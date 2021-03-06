/** Imperfect query to figure out how many users recorded games on NemeStats and then subsequently recorded games via the BG Stats app*/
SELECT DISTINCT PlayedGame.GamingGroupId
FROM PlayedGame INNER JOIN PlayedGameApplicationLinkage ON PlayedGame.Id = PlayedGameApplicationLinkage.PlayedGameId 
	AND PlayedGameApplicationLinkage.ApplicationName = 'NemeStats'
WHERE EXISTS (SELECT TOP 1 1 FROM PlayedGame PG2 INNER JOIN PlayedGameApplicationLinkage PGAL2 ON PG2.Id = PGAL2.PlayedGameId 
	AND PGAL2.ApplicationName = 'BgStats' AND PG2.DateCreated > PlayedGame.DateCreated)
