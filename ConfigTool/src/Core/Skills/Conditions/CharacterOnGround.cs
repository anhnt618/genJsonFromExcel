﻿using System;

namespace Core.Skills.Conditions {
	public class CharacterOnGround : Condition {
		private Character character;

		public CharacterOnGround(Character character) {
			if (character == null) {
				throw new NullReferenceException("Character is null");
			}

			this.character = character;
		}

		public bool IsMeet() {
			return character.IsOnGround();
		}

		public void Update(float dt) {
		}

		public string Reason() {
			return "Char is not on ground";
		}
	}
}
