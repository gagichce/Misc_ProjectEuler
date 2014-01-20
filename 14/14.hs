coltz n xs
	| n == 1 = 1 : xs
	| even n = coltz (n `div` 2) (n:xs)
	| odd n = coltz (3*n +1) (n:xs)
	
maxis = [(length (coltz x []),x) | x<- [1..999999]]

getMax :: (Int, Integer) -> [(Int,Integer)] -> (Int,Integer)
getMax n xs
	| xs == [] = n
	| fst (head xs) > fst n = getMax (head xs) (tail xs)
	| otherwise = getMax n (tail xs)