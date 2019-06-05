package queue;

import java.util.LinkedList;
import java.util.Queue;

public class CommandQueue {
	public Queue<String> queue = new LinkedList<>();
	
	public void addDirection(String direction) {
		queue.add(direction);
	}
	
	public String getDirection() {
		return  queue.poll();
	}
}
