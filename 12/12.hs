numFactors n m xs
	| n == m = m : xs
	| n `mod` m == 0 = numFactors n (m+1) (m:xs)
	| otherwise = numFactors n (m+1) xs
	
intS n = sum [1..n]

nums n
	| length (numFactors (intS n) 1 []) > 500 = intS n
	| otherwise = nums (n+1)