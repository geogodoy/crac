package com.crac.gerenciador;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.Configuration;

@SpringBootApplication
@Configuration
public class GerenciadorCracApplication {

	public static void main(String[] args) {
		SpringApplication.run(GerenciadorCracApplication.class, args);
	}
}