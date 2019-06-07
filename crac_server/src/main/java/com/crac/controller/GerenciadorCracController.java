package com.crac.controller;

import com.crac.queue.CommandQueue;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.MediaType;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.annotation.RestController;

import com.crac.queue.CommandQueue;

@RestController
public class GerenciadorCracController {
	@Autowired
	private CommandQueue commandQueue;

	@RequestMapping(
			value = "/command/sendDirection/{direction}",
			method = RequestMethod.POST,
			produces = MediaType.APPLICATION_JSON_VALUE
			)
	public void sendDirection(@PathVariable String direction) {
		commandQueue.addDirection(direction);
	}
	
	@RequestMapping(
			value = "/command/get",
			method = RequestMethod.GET,
			produces = MediaType.APPLICATION_JSON_VALUE
			)
	@ResponseBody
	public String get() {
		return "{nome: felipe}"; //commandQueue.getDirection();
	}
}