format:
	dotnet format

clean:
	dotnet clean

run:
	dotnet build && dotnet run --project BooberBreakfast

redis:
	docker run -p 6379:6379 -it redis/redis-stack-server:latest
