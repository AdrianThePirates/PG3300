﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Snake {
	class Factory {

		private static Position position;
		private static Snake snake;
		private static Food food;
		private static Random random;
		private static Stopwatch stopwatch;

		public static Position CreatePosition(int xCord = 0, int yCord = 0, Position location = null) {
			if(location != null) {
				position = new Position(location);
			} else {
				position = new Position(xCord,yCord);
			}
			return position;	
		}

		public static Snake CreateSnake() {
			snake = new Snake();
			return snake;
		}

		public static Food CreateFood() {
			food = new Food();
			return food;
		}

		public static Random CreateRandom() {
			random = new Random();
			return random;
		}

		public static Stopwatch CreateStopwatch() {
			if(stopwatch == null) {
				stopwatch = new Stopwatch();
			}
			return stopwatch;
		}
	}
}