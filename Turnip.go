// Given an array of turnip price on a day(i.e.[20,5,50] would mean day 0 the price is 20, day 1 the price is 5, day 2 the price is 50), for each day, find out how long you would have to wait before you can sell the turnip at a better price. If there is no day that the price is better, use 0 instead.
// Example: [12,15,16,12,10,13,21,14,20,19]
// Output: [1,1,4,1,1,2,0,1,0,0]

// complexity: better than O(n^2)

func turnip ( prices [] int32 ) [] int32 { 
	 var  result [] int32
	 for  i :=  0 ; i < len(prices); i++ { 
		result = append(result,  0 )
	 } 
	 for  i :=  0 ; i < len(prices); i++ { 
		 for  j := i +  1 ; j < len(prices); j++ { 
			 if  prices[j] > prices[i] { 
				result[i] = int32(j - i)
				 break 
			 } 
		 } 
	 } 
	 return  result
 }