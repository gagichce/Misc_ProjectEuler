propDiv n = [x | x <- [1..(n-1)], n `mod` x == 0]

--where m and n aren't equal
areAmicable n m = (&&) (sum (propDiv n) == m)  ( (&&) (m /= n) (sum (propDiv m) == n))

findAns = sum [x + y | x <- [1..10000], y <- [1..10000]]