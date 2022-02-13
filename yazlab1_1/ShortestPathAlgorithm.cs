using GMap.NET;
using System;
using System.Collections.Generic;

namespace yazlab1_1
{
	internal class ShortestPathAlgorithm
	{
		internal static int V;

		internal static List<int> travellingSalesmanProblem(double[,] graph, int s, int pointListCount)
		{
			V = pointListCount;
			List<int> vertex = new List<int>();

			for (int i = 0; i < V; i++)
			{
				if (i != s)
				{
					vertex.Add(i);
				}
			}
			double min_path = int.MaxValue;
			List<int> shortestPath = new List<int>();
			do
			{
				double current_pathweight = 0;
				int k = s;

				for (int i = 0; i < vertex.Count; i++)
				{
					current_pathweight += graph[k,vertex[i]];
					k = vertex[i];
					shortestPath.Add(vertex[i]);
				}

				min_path = Math.Min(min_path, current_pathweight);

				if (min_path == current_pathweight)
				{
					if (shortestPath.Count > vertex.Count)
					{
						shortestPath.RemoveRange(0, vertex.Count);
					}
                }
				else
				{
					shortestPath.RemoveRange(shortestPath.Count - vertex.Count, vertex.Count);
				}
			} while (findNextPermutation(vertex));

			return shortestPath;
		}

		public static List<int> swap(List<int> data, int left, int right)
		{
			int temp = data[left];
			data[left] = data[right];
			data[right] = temp;
			return data;
		}
		
		public static List<int> reverse(List<int> data, int left, int right)
		{
			while (left < right)
			{
				int temp = data[left];
				data[left++] = data[right];
				data[right--] = temp;
			}
			return data;
		}

		public static bool findNextPermutation(List<int> data)
		{

			if (data.Count <= 1)
			{
				return false;
			}

			int last = data.Count - 2;

			while (last >= 0)
			{
				if (data[last] < data[last + 1])
				{
					break;
				}
				last--;
			}

			if (last < 0)
			{
				return false;
			}

			int nextGreater = data.Count - 1;

			for (int i = data.Count - 1; i > last; i--)
			{
				if (data[i] > data[last])
				{
					nextGreater = i;
					break;
				}
			}

			data = swap(data, nextGreater, last);

			data = reverse(data, last + 1, data.Count - 1);


			return true;
		}

		public List<int> shortestPath(List<PointLatLng> pointList)
		{
			Distance distance = new Distance();
			double[,] graph = new double[pointList.Count, pointList.Count];
			int s = 0;
			
			for (int i = 0; i < pointList.Count; i++)
			{
				for (int j = 0; j < pointList.Count; j++)
				{
					graph[i, j] = distance.getDistance(pointList[i], pointList[j]);
				}
			}
			
			return travellingSalesmanProblem(graph, s, pointList.Count);
		}
	}
}

