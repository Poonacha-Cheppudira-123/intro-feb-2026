#!/bin/bash

# Get list of directories in src/app/areas excluding 'shared'
areas_dir="src/app/areas"
areas=()

# Read directories into array
while IFS= read -r dir; do
    basename=$(basename "$dir")
    if [ "$basename" != "shared" ]; then
        areas+=("$basename")
    fi
done < <(find "$areas_dir" -mindepth 1 -maxdepth 1 -type d | sort)

# Check if any areas were found
if [ ${#areas[@]} -eq 0 ]; then
    echo "No areas found in $areas_dir (excluding 'shared')"
    exit 1
fi

# Display menu of areas
echo "Select an area:"
select area in "${areas[@]}"; do
    if [ -n "$area" ]; then
        echo "Selected area: $area"
        break
    else
        echo "Invalid selection. Please try again."
    fi
done

# Ask for feature name
read -p "Enter the name of the feature: " feature_name

# Validate feature name is not empty
if [ -z "$feature_name" ]; then
    echo "Feature name cannot be empty"
    exit 1
fi

# Run the scaffold command
echo "Running: npx simple-scaffold -n $feature_name -o src/app/areas/$area -t .templates/landing-feature"
npx simple-scaffold -n "$feature_name" -o "src/app/areas/$area" -t .templates/landing-feature
