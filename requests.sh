#!/bin/bash


FQDN=localhost:3000
CONTENT_TYPE="Content-Type: application/json"

if [[ $1 == "" ]]; then
    echo nothing done
fi

if [[ $1 == "post" ]]; then
	if [[ $2 == "/test/cache" ]]; then
		curl -w "\n" --header $CONTENT_TYPE --request POST \
			--data '{"key":"ryan","value":"p"}' \
			$FQDN/test/cache
	fi
fi

if [[ $1 == "get" ]]; then
	if [[ $2 == "/test/cache/" ]]; then
		curl -w "\n" --header $CONTENT_TYPE --request POST \
			--data '{"key":"ryan","value":"p"}' \
			$FQDN/test/cache
	fi
fi
