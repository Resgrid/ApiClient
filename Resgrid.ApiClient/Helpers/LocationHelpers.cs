﻿using System;
using System.Text.RegularExpressions;

namespace Resgrid.ApiClient.Helpers
{
	public static class LocationHelpers
	{
		public static double ConvertDegreesToDecimal(string degrees, string minutes, string seconds)
		{
			double decimalCoordinate = 0;

			double newDegrees = Double.Parse(degrees);
			double newMinutes = Double.Parse(minutes) / 60;
			double newSeconds = Double.Parse(seconds) / 3600;

			if (newDegrees > 0)
			{
				decimalCoordinate = (newDegrees + newMinutes + newSeconds);
			}
			else
			{
				decimalCoordinate = (newDegrees - newMinutes - newSeconds);
			}

			return decimalCoordinate;
		}

		public static bool IsDMSLocation(string point)
		{
			return (point.Contains("S") || point.Contains("W") || point.Contains("'") || point.Contains("\""));
		}

		public static double ConvertDegreeAngleToDouble(string point)
		{
			//Example: 17.21.18S

			var multiplier = (point.Contains("S") || point.Contains("W")) ? -1 : 1; //handle south and west

			point = Regex.Replace(point, "[^0-9. ]", ""); //remove the characters

			var pointArray = point.Trim().Split(' '); //split the string.

			//Decimal degrees = 
			//   whole number of degrees, 
			//   plus minutes divided by 60, 
			//   plus seconds divided by 3600

			var degrees = Double.Parse(pointArray[0]);
			var minutes = Double.Parse(pointArray[1]) / 60;
			var seconds = Double.Parse(pointArray[2]) / 3600;

			return (degrees + minutes + seconds) * multiplier;
		}
	}
}
