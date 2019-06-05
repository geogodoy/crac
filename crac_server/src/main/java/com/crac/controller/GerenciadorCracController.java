package com.crac.controller;

import java.util.List;

import javax.xml.ws.Response;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.crac.entities.Comando;
import com.crac.services.ComandoServices;

@RestController
@RequestMapping("/api/comando")
public class GerenciadorCracController {
	@Autowired
	private ComandoServices comandoService;

	// @PostMapping(path = "/new")
	// public ResponseEntity<Response<Comando>> cadastrar(@Valid @RequestBody
	// ComandoDto viagemDto, BindingResult result) {
	// Response<Comando> response = new Response<Comando>();
	//
	// if (result.hasErrors()) {
	// result.getAllErrors().forEach(error ->
	// response.getErrors().add(error.getDefaultMessage()));
	// return ResponseEntity.badRequest().body(response);
	// }
	//
	// Comando comandoSalva = this.comandoService.salvar(viagemDto);
	// URI location =
	// ServletUriComponentsBuilder.fromCurrentRequest().path("/{id}").buildAndExpand(viagemDto.getId()).toUri();
	// response.setData(comandoSalva);
	// return ResponseEntity.created(location).body(response);
	// }

	@GetMapping
	public ResponseEntity<List<Comando>> listar() {
		List<Comando> viagens = comandoService.listar();
		return ResponseEntity.status(HttpStatus.OK).body(viagens);
	}

	@GetMapping(path = "/{id}")
	public ResponseEntity<Response<Comando>> buscar(@PathVariable("id") Long id) {

		Comando comando = comandoService.buscar(id);
		Response<Comando> response = new Response<Comando>();
		response.setData(comando);
		return ResponseEntity.status(HttpStatus.OK).body(response);
	}
}
