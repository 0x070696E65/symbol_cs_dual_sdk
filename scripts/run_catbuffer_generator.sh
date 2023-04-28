#!/bin/bash

set -ex

function generate_code() {
	# $1 blockchain
	# $2 destination

	local git_root
	git_root="$(git rev-parse --show-toplevel)"

	PYTHONPATH="${git_root}/catbuffer/parser" python3 -m catparser \
		--schema "${git_root}/catbuffer/schemas/$1/all_generated.cats"  \
		--include "${git_root}/catbuffer/schemas/$1" \
		--output "${git_root}/CatSdk/$2" \
		--quiet \
		--generator Generator.Generator
}

if [[ $# -eq 0 ]]; then
	echo "updating generated code in git"
	for name in "Nem" "Symbol";
	do
		rm -rf "./CatSdk/${name}/models.cs"
		generate_code "${name}" "${name}"
	done
elif [[ "$1" = "dryrun" ]]; then
	echo "running dryrun diff"

	for name in "Nem" "Symbol";
	do
		generate_code "${name}" "${name}2"
		diff "./CatSdk/${name}/models.cs" "./CatSdk/${name}2/models.cs"
		rm -rf "./CatSdk/${name}2/models.cs"
	done
else
	echo "unknown options"
	exit 1
fi
