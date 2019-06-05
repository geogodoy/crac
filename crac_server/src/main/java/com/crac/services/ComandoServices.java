package com.crac.services;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.crac.dtos.ComandoDto;
import com.crac.entities.Comando;
import com.crac.repositories.ComandoRepository;


@Service
public class ComandoServices {

	@Autowired
	private ComandoRepository comandoRepository;

	public List<Comando> listar() {
		return comandoRepository.findAll();
	}

	public Comando salvar(ComandoDto comandoDto) {

		Comando comando = new Comando();

		comando.setLocalDeDestino(comandoDto.getLocalDeDestino());
		comando.setDataPartida(comandoDto.getDataPartida());
		comando.setDataRetorno(comandoDto.getDataRetorno());
		comando.setAcompanhante(comandoDto.getAcompanhante());
		return comandoRepository.save(comando);
	}

	public Comando buscar(Long id) {
		Comando comando = comandoRepository.findOne(id);

		// if (comando == null) {
		// throw new ComandoServiceException("Erro");
		// }
		return comando;
	}
}
