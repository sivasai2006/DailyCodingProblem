public class Solution {

	public static void main(String args[]) {
		int[] intArray = new int[]{ 1, 2, 3, 4, 5}; 
		
		uberArray(intArray);
	}
	
	public static void uberArray(int[] intArray) {
		int[] uberArray = new int[intArray.length];
		
		for(int i=0;i<intArray.length;i++)
		{ 
			int val=1;
			for(int j=0;j<intArray.length;j++)
			{
				if(i!=j)
				{
					val *= intArray[j];
				}
				uberArray[i] = val;
			}
			System.out.println(uberArray[i]);
		}
	}
}
