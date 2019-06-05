package com.crac.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import queue.CommandQueue;

@RestController
@RequestMapping("/api/command")
public class GerenciadorCracController {
	@Autowired
	private CommandQueue commandQueue;

	@PostMapping("/sendDirection/{direction}")
	public void sendDirection(@PathVariable String direction) {
		commandQueue.addDirection(direction);
	}
	
	@GetMapping("/getDirection")
	public String getDirection() {
		return commandQueue.getDirection();
	}
}