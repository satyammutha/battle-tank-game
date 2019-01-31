﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Inputs;
using Common;

namespace Player
{
    public class PlayerManager : Singleton<PlayerManager>
    {
        public PlayerController playerController { get; private set; }

        // Use this for initialization
        void Start()
        {
            SpawnTank();

        }

        private void SpawnTank()
        {
            playerController = new PlayerController();
            InputManager.Instance.playerController = playerController;
        }

        public void DestroyPlayer(PlayerController _playerController)
        {
            _playerController.DestroyPlayer();
            _playerController = null;
        }
    }
}