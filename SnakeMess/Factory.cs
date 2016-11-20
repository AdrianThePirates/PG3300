﻿using System;
using System.Diagnostics;

namespace Snake {
	class Factory {

		private static Position position;
		private static Snake snake;
		private static Food food;
		private static Random random;
		private static Stopwatch stopwatch;
		private static GUI GUI;
		private static GameState gameState;
		private static Action action;

		public static Position CreatePosition(int xCord = 0, int yCord = 0, Position location = null) {
			if(location != null) {
				position = new Position(location);
			} else {
				position = new Position(xCord,yCord);
			}
			return position;	
		}

		public static Snake CreateSnake() {
			if(snake == null) {
				snake = new Snake();
			}
			return snake;
		}

		public static Food CreateFood() {
			if(food == null) {
				food = new Food();
			}
			return food;
		}

		public static Random CreateRandom() {
			if(random == null) {
				random = new Random();
			}
			return random;
		}

		public static Stopwatch CreateStopwatch() {
			if(stopwatch == null) {
				stopwatch = new Stopwatch();
			}
			return stopwatch;
		}

		public static GUI CreateGUI() {
			if(GUI == null) {
				GUI = new GUI();
			}
			return GUI;
		}

		public static GameState CreateGameState() {
			if(gameState == null) {
				gameState = new GameState();
			}
			return gameState;
		}

		public static Action CreateAction() {
			if(action == null) {
				action = new Action();
			}
			return action;
		}
	}
}
