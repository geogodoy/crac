package com.crac.repositories;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.crac.entities.Comando;

@Repository

public class ComandoRepository extends JpaRepository<Comando, Long> {

	Comando findByLocalDeDestino(String localDeDestino);

}
