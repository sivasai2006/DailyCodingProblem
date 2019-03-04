import java.util.ArrayList;
import java.util.Arrays;

public class Solution {
	public static void main(String args[]) {
		ArrayList<Integer> inputAL = new ArrayList<Integer>( Arrays.asList(3, 4, -1, 1) ); 
		
		int minPositiveNumber = GetMinimalPositiveNumber(inputAL);
		
		System.out.println(minPositiveNumber);
	}
	
	public static int GetMinimalPositiveNumber(ArrayList<Integer> inputAL)
	{
		int minPositiveNumber = 1;
		while (true)
		{
			if (!inputAL.contains(minPositiveNumber))
			{
				break;
			}

			minPositiveNumber++;
		}

		return minPositiveNumber;
	}
}
